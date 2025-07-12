# Contributing to WiNode

Thanks for your interest in contributing to **WiNode**, the Windows-native Node.js version manager! This guide outlines the processes and conventions that help maintain a clean, predictable, and stable development experience.

## 📋 General Guidelines

* All changes must be submitted through Pull Requests (PRs).
* PRs will be **squashed and rebased** onto the `main` branch upon merge.
* Keep PRs focused: one feature or fix per PR.
* Ensure all tests pass before submitting a PR.
* Be respectful and constructive in all interactions.
* :warning: **Unsigned commits will be rejected!** _For more information, see [GitHub's documentation on signing commits](https://docs.github.com/en/authentication/managing-commit-signature-verification/signing-commits)._

## 🔄 Contribution Process

* Fork the repository on GitHub.
* Create a new branch in your fork using a meaningful name:
  * Prefix with `feature/` for new features
  * Prefix with `bugfix/` or `hotfix/` for patches
* Make your changes locally.
* Push your branch to your fork.
* Submit a Pull Request (PR) back to the main WiNode repository.

    _See [Commit Message Format](#commit-message-format) for PR title and description guidelines._

## 🚀 Versioning and GitVersion

WiNode uses [GitVersion](https://gitversion.net/) to manage versioning automatically based on [Conventional Commits](https://www.conventionalcommits.org/). No manual version bumps are needed.

### Commit Message Format

Use the following structure in PR **titles**:

```
<type>[optional scope][!]: <description>
```

Use the **PR description** as the body of a multi-line commit message.

### Version Bump Rules

| Commit Type | Description     | Version Bump |
| ----------- | --------------- | ------------ |
| `feat:`     | New features    | Minor        |
| `fix:`      | Bug fixes       | Patch        |
| `!` in type | Breaking change | Major        |

#### Examples

```
feat: add winode uninstall command
fix(config): handle malformed JSON in settings
feat(cli)!: drop support for legacy args
```

#### Multi-line Breaking Changes

You can also indicate breaking changes in the PR description:

```
BREAKING CHANGE: renames `winode ls` to `winode list` for clarity.
```

Both the `!` and `BREAKING CHANGE:` footer can be used together.

#### Branch Naming

For convenience, when building the project from a branch in your development fork, **GitVersion will automatically treat branches starting with `feature/` as a minor bump and branches starting with `bugfix/` or `hotfix/` as a patch bump**.

## 🧪 Testing & Code Quality

* Please write tests for any new functionality.
* Run all tests locally before submitting.
* Lint your code using the provided configuration.

## 📄 Pull Request Expectations

GitHub will use the PR title and description as the final squashed commit message.

* ✅ **Title** must follow Conventional Commit format.
* ✅ **Description** should provide detailed context (like a multi-line commit body).
* ❗ Additional discussion should happen in PR **comments**, not the description.

---

Thank you for contributing to WiNode! 🎉
