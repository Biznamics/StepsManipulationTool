# Steps Manipulation Tool (XrmToolBox)

**A power tool for Dataverse / Dynamics 365 plugin step refactoring.**  
Move plugin steps between plugin types while **preserving step GUIDs** — useful when you need to restructure assemblies or classes without breaking identity.

> ⚠️ **Advanced tool — use with care**
> This tool performs direct updates to plugin step metadata. Always test in DEV/UAT first and keep a backup/export.

---

## What is this?

Steps Manipulation Tool is an **XrmToolBox plugin** for **advanced refactoring** of **SDK message processing steps** (plugin steps), including moving steps between plugin types while keeping the **same Step Id (GUID)**.

Typical reasons you might need this:
- You’re splitting a big plugin assembly into smaller ones.
- You’re moving steps from one plugin class to another during refactoring.
- You want to keep the original step identity (GUID) to reduce churn and avoid reconfiguration noise.

By preserving step GUIDs, you can help maintain existing configurations, such as:
- Custom automation or tooling that references a step by its GUID.
- ALM flows where changes should apply as **updates to existing step components** rather than creating new steps.
- Third-party tools or integrations that rely on specific step identities.

---

## How it works (high level)

Normally, moving/recreating steps during refactoring often results in **new step records** (new GUIDs).  
This tool updates existing `sdkmessageprocessingstep` records so they reference the **new plugin type**, while keeping the original step identity.

### ALM note
If you perform the move in **DEV** and then export/import a solution, the target environment is more likely to receive the change as an **update to the same step component** (instead of creating brand new steps), which helps steps “move with” your refactor.

> Note: behavior can still vary depending on managed/unmanaged solutions, what components exist in the target environment, and how your solution layering is set up.

---

## Features

- ✅ Move plugin steps between plugin types **and preserve step GUIDs**
- ✅ Designed for **refactoring / restructuring** plugin implementations
- ✅ Built as an **XrmToolBox** tool, so it works in the same workflow you already use

> If you use it for anything beyond refactoring, you probably want to re-think the approach first 🙂

---

## Getting started

### Install (recommended)
1. Open **XrmToolBox**
2. Go to **Tools → Tool Library**
3. Search for: **Steps Manipulation Tool**
4. Install and restart XrmToolBox if needed

### Run
1. Connect to your Dataverse/Dynamics environment
2. Open **Steps Manipulation Tool**
3. Select the **source** step(s)
4. Select the **target plugin type**
5. Execute the operation
6. Verify the steps behave as expected (see checklist below)

---

## Safety checklist (please don’t skip)

Before running advanced operations:
- [ ] Export a solution containing the affected assembly/steps (or take a backup/snapshot)
- [ ] Prefer testing in DEV/UAT first
- [ ] Make sure you understand the **target plugin type** and its pipeline behavior
- [ ] Verify results after the move:
  - Step still triggers when expected
  - Filtering attributes / images / execution mode are intact
  - No duplicate step exists
- [ ] If your org has ALM pipelines, coordinate the change so solutions don’t “fight” each other

---

## Compatibility

- Targets **.NET Framework 4.8** (XrmToolBox runtime)
- Intended for **Microsoft Dataverse / Dynamics 365 Customer Engagement** environments via XrmToolBox

---

## Development

### Prerequisites
- Visual Studio (any recent version that supports .NET Framework development)
- XrmToolBox tooling references restored successfully

### Build
- Open the solution in Visual Studio
- Restore NuGet packages
- Build in **Release**

### CI/CD (GitHub Actions)

Two workflows live in `.github/workflows/`:

| Workflow | Trigger | What it does |
|---|---|---|
| `build.yml` | Push to any branch / PR to master | Restores, builds in Release, packs the `.nupkg`, and uploads it as a versioned artifact |
| `release.yml` | Manual (`workflow_dispatch`) | Downloads the `.nupkg` from a chosen CI run, publishes to [nuget.org](https://www.nuget.org/packages/ImranAkram.XTB.StepManipulationTool), and creates a GitHub release |

Versions are auto-generated as `1.{yyyy}.{M}.{rev}` (e.g. `1.2026.4.3`) where `rev` is the monthly CI build count.

**Required secret:** `NUGET_API_KEY` — a nuget.org API key with push access, stored in repo Settings → Secrets → Actions.

#### How to publish a release

The `.nupkg` is built and validated by CI — the release workflow just promotes it. No rebuild happens at release time.

1. Go to the **Actions** tab and find the `CI Build` run you want to ship (typically the latest green run on `master`).
2. Copy the **run ID** from the URL: `https://github.com/.../actions/runs/`**`<run_id>`**
3. Go to **Actions → Release → Run workflow**, paste the run ID, and click **Run workflow**.
4. The workflow will push the `.nupkg` to nuget.org and create a tagged GitHub release automatically.

### Debug (optional)
- Copy the built plugin output to your local XrmToolBox `Plugins` folder (or use your existing XTB dev workflow)
- Start XrmToolBox and load the tool

---

## License
MIT — see [LICENSE](LICENSE).

## Support / contributions
Issues and PRs are welcome. For bug reports, please include:
- XrmToolBox version
- Auth type (Client Secret / Certificate / etc.)
- Dataverse region (optional)
- Steps to reproduce + expected/actual behavior
